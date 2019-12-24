package com.ydzw.smartim;

import com.ydzw.smartim.androidtest.DownloadFile;
import com.ydzw.smartim.enumtype.MessageType;
import com.ydzw.smartim.netty.protocol.BaseProtocol;
import com.ydzw.smartim.netty.protocol.ReceiveProtocol;
import com.ydzw.smartim.util.JsonUtils;
import io.netty.channel.ChannelHandlerContext;
import io.netty.channel.SimpleChannelInboundHandler;
import io.netty.util.CharsetUtil;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import java.net.URLEncoder;

public class ClientHandlerTest extends SimpleChannelInboundHandler<BaseProtocol> {
    private Logger logger = LoggerFactory.getLogger(this.getClass());

    @Override
    protected void channelRead0(ChannelHandlerContext channelHandlerContext, BaseProtocol baseProtocol) throws Exception {
        logger.info("进入读数据方法");
        int len = baseProtocol.getLen();
        if(len > 4){
            byte[] content = baseProtocol.getContent();
            String resultContent = new String(content, CharsetUtil.UTF_8);
            System.out.println(resultContent);

            ReceiveProtocol receiveProtocol = JsonUtils.jsonToPojo(resultContent, ReceiveProtocol.class);

            if(MessageType.SINGLE_RECYCLER_TEXT.toString().equals(receiveProtocol.getMessageType())){
                logger.info("收到 "+receiveProtocol.getFromClient()+" 单人文本消息:" + receiveProtocol.getMessage());
            }
            if(MessageType.SINGLE_RECYCLER_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                DownloadFile.downLoad("http://localhost:8080/file/download?filename=" + URLEncoder.encode(receiveProtocol.getMessage(),"utf-8"),receiveProtocol.getMessage());
                logger.info("收到 "+receiveProtocol.getFromClient()+" 单人图片消息:" + receiveProtocol.getMessage());
            }
            if(MessageType.SINGLE_RECYCLER_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                DownloadFile.downLoad("http://localhost:8080/file/download?filename=" + URLEncoder.encode(receiveProtocol.getMessage(),"utf-8"),receiveProtocol.getMessage());
                logger.info("收到 "+receiveProtocol.getFromClient()+" 单人文件消息:" + receiveProtocol.getMessage());
            }

            if(MessageType.MEETING_RECYCLER_TEXT.toString().equals(receiveProtocol.getMessageType())){
                logger.info("收到 "+receiveProtocol.getFromClient()+" 群聊文本消息:" + receiveProtocol.getMessage());
            }

            if(MessageType.MEETING_RECYCLER_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                DownloadFile.downLoad2("http://localhost:8080/file/download?filename=" + URLEncoder.encode(receiveProtocol.getMessage(),"utf-8"),receiveProtocol.getMessage());
                logger.info("收到 "+receiveProtocol.getFromClient()+" 群聊图片消息:" + receiveProtocol.getMessage());
            }

            if(MessageType.MEETING_RECYCLER_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                DownloadFile.downLoad2("http://localhost:8080/file/download?filename=" + URLEncoder.encode(receiveProtocol.getMessage(),"utf-8"),receiveProtocol.getMessage());
                logger.info("收到 "+receiveProtocol.getFromClient()+" 群聊文件消息:" + receiveProtocol.getMessage());
            }


            if(MessageType.SINGLE_RECYCLER_CALLING.toString().equals(receiveProtocol.getMessageType())){
                logger.info("收到 "+receiveProtocol.getFromClient()+" 一对一电话:" + receiveProtocol.getMessage());
            }

            if(MessageType.MEETING_RECYCLER_CALLING.toString().equals(receiveProtocol.getMessageType())){
                logger.info("收到 "+receiveProtocol.getFromClient()+" 会议电话:" + receiveProtocol.getMessage());
            }

            if(MessageType.RECYCLER_EXIT.toString().equals(receiveProtocol.getMessageType())){
                logger.info("收到 "+receiveProtocol.getFromClient()+" 文本消息:" + receiveProtocol.getMessage());
                channelHandlerContext.channel().close();
            }
        }
    }
}
