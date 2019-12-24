package com.ydzw.smartim.netty;

import com.ydzw.smartim.netty.protocol.BaseProtocol;
import io.netty.buffer.ByteBuf;
import io.netty.channel.ChannelHandlerContext;
import io.netty.handler.codec.MessageToByteEncoder;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class MessageEncoder extends MessageToByteEncoder<BaseProtocol> {
    private Logger logger = LoggerFactory.getLogger(this.getClass());
    @Override
    protected void encode(ChannelHandlerContext channelHandlerContext, BaseProtocol baseProtocol, ByteBuf byteBuf) throws Exception {
        logger.info("服务器的编码器 encode 方法被调用。。");
        byteBuf.writeInt(baseProtocol.getLen());
        byteBuf.writeBytes(baseProtocol.getContent());
        logger.info("转发成功。。。");
    }
}
