package com.ydzw.smartim.util;

import com.ydzw.smartim.constant.MessageConstants;
import com.ydzw.smartim.netty.protocol.BaseProtocol;
import com.ydzw.smartim.netty.protocol.ReceiveProtocol;
import io.netty.channel.Channel;
import io.netty.channel.group.ChannelGroup;
import io.netty.util.CharsetUtil;

public class SendMessageUtils {

    public static BaseProtocol jsonToBytes(Object receiveProtocol){
        String responseContent = JsonUtils.objectToJson(receiveProtocol);
        int responseLen = responseContent.getBytes(CharsetUtil.UTF_8).length;
        byte[]  responseContent2 = responseContent.getBytes(CharsetUtil.UTF_8);
        BaseProtocol protocol = new BaseProtocol();
        protocol.setLen(responseLen);
        protocol.setContent(responseContent2);
        return protocol;
    }

    public static void sendMessage(Channel receiveChannel,ReceiveProtocol receiveProtocol, ChannelGroup userChannels,String type){
        if(receiveChannel == null){
            //用户离线，应做推送处理
        }else {
            //查找对应的channel是否存在
            Channel findChannel = userChannels.find(receiveChannel.id());
            if(findChannel != null){
                //用户在线
                receiveProtocol.setMessageType(type);
                BaseProtocol returnBaseProtocol = SendMessageUtils.jsonToBytes(receiveProtocol);
                receiveChannel.writeAndFlush(returnBaseProtocol);
            }
        }
    }



    public static void sendSingleMessage(ReceiveProtocol receiveProtocol, ChannelGroup userChannels,String type){
        Channel receiveChannel = MessageConstants.allOnlineUsers.get(receiveProtocol.getToClient().get(0));
        sendMessage(receiveChannel,receiveProtocol,userChannels,type);
    }


    public static void sendMeetingMessage(ReceiveProtocol receiveProtocol, ChannelGroup userChannels,String type){
        //这里查询数据库对所属群组进行操作
        for (int i = 0;i < receiveProtocol.getToClient().size();i++) {
            Channel receiveChannel = MessageConstants.allOnlineUsers.get(receiveProtocol.getToClient().get(i));
            sendMessage(receiveChannel,receiveProtocol,userChannels,type);
        }
    }
}
