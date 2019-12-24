package com.ydzw.smartim.netty.protocol;

import com.ydzw.smartim.enumtype.MessageType;

public class MessageRequest {

    /**
     * id 客户端标识（PC、ANDROID、RW、WEB）
     */
    private String platFromId;

    private Enum<MessageType> messageType;

    public String getPlatFromId() {
        return platFromId;
    }

    public void setPlatFromId(String platFromId) {
        this.platFromId = platFromId;
    }

    public Enum<MessageType> getMessageType() {
        return messageType;
    }

    public void setMessageType(Enum<MessageType> messageType) {
        this.messageType = messageType;
    }
}
