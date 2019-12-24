package com.ydzw.smartim.netty.messagehandler;

import io.netty.channel.ChannelHandlerContext;

public interface ICommandHandler<T> {

    void handle(ChannelHandlerContext ctx,T inBound) throws Exception;
}
