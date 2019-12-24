package com.ydzw.smartim.enumtype;

public enum MessageType {
    /**
     * 1.端对端文本消息
     */
    SINGLE_TEXT,


    /**
     * 2.端对端图片消息
     */
    SINGLE_IMAGE_TEXT,

    /**
     * 3.端对端文件消息
     */
    SINGLE_FILE_TEXT,

    /**
     * 4.端对端转发文本消息
     */
    SINGLE_RECYCLER_TEXT,

    /**
     * 5.端对端转发文件消息
     */
    SINGLE_RECYCLER_FILE_TEXT,

    /**
     * 6.端对端转发图片消息
     */
    SINGLE_RECYCLER_IMAGE_TEXT,

    /**
     * 7.群聊文本消息
     */
    MEETING_TEXT,

    /**
     * 8.群聊图片消息
     */
    MEETING_IMAGE_TEXT,

    /**
     * 9.群聊文件消息
     */
    MEETING_FILE_TEXT,

    /**
     * 10.群聊转发文本消息
     */
    MEETING_RECYCLER_TEXT,

    /**
     * 11.群聊转发文件消息
     */
    MEETING_RECYCLER_FILE_TEXT,

    /**
     * 12.群聊转发图片消息
     */
    MEETING_RECYCLER_IMAGE_TEXT,

    /**
     * 13.一对一远程指导
     */
    SINGLE_CALLING,

    /**
     * 14.多人远程指导
     */
    MEETING_CALLING,
    /**
     * 15.一对一转发远程指导
     */
    SINGLE_RECYCLER_CALLING,

    /**
     * 16.多人转发远程指导
     */
    MEETING_RECYCLER_CALLING,

    /**
     * 17.退出
     */
    EXIT,

    /**
     * 18.退出回执
     */
    RECYCLER_EXIT,

    /**
     * 19.客户端连接协议
     */
    CONNECT,

    /**
     * 20.连接回执
     */
    RECYCLER_CONNECT,



    QUIT,
    GETROOMID,
    MEETINGQUIT,
    INSIDEREGISTE,
    CHECKUSER,
    GETMEETINGLIST,
    AUDIO;

//    {"messageType":"SINGLE_IMAGE_TEXT","fromClient":"777","toClient":["123","456"],"message":"你好","roomId":"r101"}

}
