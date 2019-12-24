package com.ydzw.smartim.constant;

import io.netty.channel.Channel;

import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

public class MessageConstants {
    public static int port = 12345;

    public static Map<List<String>, Channel> sendToOther = new ConcurrentHashMap<>();

    public static Map<String,Channel> pcOnlineUsers = new ConcurrentHashMap<>();

    public static Map<String,Channel> androidOnlineUsers = new ConcurrentHashMap<>();

    public static Map<String,Channel> rwOnlineUsers = new ConcurrentHashMap<>();


    public static Map<String,Channel> allOnlineUsers = new ConcurrentHashMap<>();






}
