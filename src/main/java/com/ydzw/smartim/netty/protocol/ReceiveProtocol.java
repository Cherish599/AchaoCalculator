package com.ydzw.smartim.netty.protocol;

import java.util.List;

public class ReceiveProtocol {
    private String messageType;
    private String fromClient;
    private List<String> toClient;
    private String message;
    private String roomId;

    public List<String> getToClient() {
        return toClient;
    }

    public void setToClient(List<String> toClient) {
        this.toClient = toClient;
    }

    public String getMessageType() {
        return messageType;
    }

    public void setMessageType(String messageType) {
        this.messageType = messageType;
    }

    public String getFromClient() {
        return fromClient;
    }

    public void setFromClient(String fromClient) {
        this.fromClient = fromClient;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public String getRoomId() {
        return roomId;
    }

    public void setRoomId(String roomId) {
        this.roomId = roomId;
    }
}
