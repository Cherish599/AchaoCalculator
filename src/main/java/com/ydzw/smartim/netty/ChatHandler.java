package com.ydzw.smartim.netty;

import com.ydzw.smartim.constant.MessageConstants;
import com.ydzw.smartim.enumtype.MessageType;
import com.ydzw.smartim.netty.protocol.ReceiveProtocol;
import com.ydzw.smartim.netty.protocol.BaseProtocol;
import com.ydzw.smartim.util.SendMessageUtils;
import com.ydzw.smartim.util.JsonUtils;
import io.netty.channel.Channel;
import io.netty.channel.ChannelHandlerContext;
import io.netty.channel.SimpleChannelInboundHandler;
import io.netty.channel.group.ChannelGroup;
import io.netty.channel.group.DefaultChannelGroup;
import io.netty.util.CharsetUtil;
import io.netty.util.concurrent.GlobalEventExecutor;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import java.util.Collection;

public class ChatHandler extends SimpleChannelInboundHandler<BaseProtocol> {

    private Logger logger = LoggerFactory.getLogger(this.getClass());
    private static ChannelGroup userChannels = new DefaultChannelGroup(GlobalEventExecutor.INSTANCE);

    //第一个被执行
    @Override
    public void handlerAdded(ChannelHandlerContext ctx) throws Exception {

        Channel channel = ctx.channel();
        logger.info("有客户端连接进来了：" + channel.remoteAddress().toString());
        userChannels.add(channel);
    }


    @Override
    public void handlerRemoved(ChannelHandlerContext ctx) throws Exception {
        Channel channel = ctx.channel();
        logger.info("有客户端离开了：" + channel.remoteAddress().toString());
        logger.info("还有 " + userChannels.size() + "个客户端");
        logger.info("Map里还有 " + MessageConstants.allOnlineUsers.size() + "个客户端");
    }


    @Override
    public void channelActive(ChannelHandlerContext ctx) throws Exception {
        logger.info(ctx.channel().remoteAddress() + " 客户端连接进来了");
    }


    @Override
    public void channelInactive(ChannelHandlerContext ctx) throws Exception {
        logger.info("移除了客户端 " + ctx.channel().remoteAddress());
    }

    @Override
    protected void channelRead0(ChannelHandlerContext channelHandlerContext, BaseProtocol baseProtocol) throws Exception {
        logger.info("进入服务端读取消息函数。。");
        Channel channel = channelHandlerContext.channel();

        int len = baseProtocol.getLen();
        byte[] content = baseProtocol.getContent();

        logger.info("接收到消息的长度为：" + len);
        String json = new String(content, CharsetUtil.UTF_8);
        logger.info(json);
        ReceiveProtocol receiveProtocol = JsonUtils.jsonToPojo(json, ReceiveProtocol.class);
        logger.info("转发数据。。。");
        if(MessageType.CONNECT.toString().equals(receiveProtocol.getMessageType())){
            MessageConstants.allOnlineUsers.put(receiveProtocol.getFromClient(),channel);
            receiveProtocol.setMessageType(MessageType.RECYCLER_CONNECT.toString());
            BaseProtocol returnBaseProtocol = SendMessageUtils.jsonToBytes(receiveProtocol);
            channelHandlerContext.writeAndFlush(returnBaseProtocol);
        }else if(MessageType.SINGLE_TEXT.toString().equals(receiveProtocol.getMessageType())){
           SendMessageUtils.sendSingleMessage(receiveProtocol,userChannels,MessageType.SINGLE_RECYCLER_TEXT.toString());

//            userChannels.forEach(ch -> {
//                if(channel != ch) { //不是当前的channel,转发消息
//                    ch.writeAndFlush(returnBaseProtocol);
//                }else {//回显自己发送的消息给自己
//                    ch.writeAndFlush(returnBaseProtocol);
//                }
//            });

        }else
        if(MessageType.SINGLE_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendSingleMessage(receiveProtocol,userChannels,MessageType.SINGLE_RECYCLER_IMAGE_TEXT.toString());

        }else if(MessageType.SINGLE_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendSingleMessage(receiveProtocol,userChannels,MessageType.SINGLE_RECYCLER_FILE_TEXT.toString());

        }else if(MessageType.MEETING_TEXT.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendMeetingMessage(receiveProtocol,userChannels,MessageType.MEETING_RECYCLER_TEXT.toString());

        }else if(MessageType.MEETING_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendMeetingMessage(receiveProtocol,userChannels,MessageType.MEETING_RECYCLER_IMAGE_TEXT.toString());

        }else
        if(MessageType.MEETING_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendMeetingMessage(receiveProtocol,userChannels,MessageType.MEETING_RECYCLER_FILE_TEXT.toString());

        }else if(MessageType.SINGLE_CALLING.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendSingleMessage(receiveProtocol,userChannels,MessageType.SINGLE_RECYCLER_CALLING.toString());

        }else if(MessageType.MEETING_CALLING.toString().equals(receiveProtocol.getMessageType())){

            SendMessageUtils.sendMeetingMessage(receiveProtocol,userChannels,MessageType.MEETING_RECYCLER_CALLING.toString());

        }else if(MessageType.EXIT.toString().equals(receiveProtocol.getMessageType())){
            receiveProtocol.setMessageType(MessageType.RECYCLER_EXIT.toString());
            BaseProtocol returnBaseProtocol = SendMessageUtils.jsonToBytes(receiveProtocol);
            channelHandlerContext.writeAndFlush(returnBaseProtocol);
            MessageConstants.allOnlineUsers.remove(receiveProtocol.getFromClient());
            channel.close();
        }else {
            MessageConstants.allOnlineUsers.remove(receiveProtocol.getFromClient());
            channel.close();
        }
    }

    /**
     * 异常情况调用
     * @param ctx
     * @param cause
     * @throws Exception
     */
    @Override
    public void exceptionCaught(ChannelHandlerContext ctx, Throwable cause) throws Exception {
        logger.error("发生异常：" + cause.getMessage());
        ctx.channel().close();
        userChannels.remove(ctx.channel());
        //按值删除
        Collection<Channel> channels = MessageConstants.allOnlineUsers.values();
        for(Channel channel:MessageConstants.allOnlineUsers.values()){
            if(channel.id().equals(ctx.channel().id())){
                channels.remove(channel);
            }
        }
    }
}
