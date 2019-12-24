package com.ydzw.smartim.netty.messagehandler;

import com.ydzw.smartim.netty.protocol.BaseProtocol;
import io.netty.channel.ChannelHandlerContext;


public abstract class AbstractServerHandler implements ICommandHandler<BaseProtocol>{

    @Override
    public void handle(ChannelHandlerContext ctx, BaseProtocol inBound) throws Exception {

    }
}
