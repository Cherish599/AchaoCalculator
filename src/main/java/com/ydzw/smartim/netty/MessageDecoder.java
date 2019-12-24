package com.ydzw.smartim.netty;

import com.ydzw.smartim.netty.protocol.BaseProtocol;
import io.netty.buffer.ByteBuf;
import io.netty.channel.ChannelHandlerContext;
import io.netty.handler.codec.ByteToMessageDecoder;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.List;

public class MessageDecoder extends ByteToMessageDecoder {
    private Logger logger = LoggerFactory.getLogger(this.getClass());

    @Override
    protected void decode(ChannelHandlerContext ctx, ByteBuf in, List<Object> out) throws Exception {
        logger.info("服务器的解码器被调用。。");
        //标记当前指针
        in.markReaderIndex();

        if(in.readableBytes() < 4){
            //判断包头长度
            return;
        }

        int length = in.readInt();
        if(length < 0){
            //长度小于0 非法数据，关闭通道
            ctx.close();
        }
        if(length > in.readableBytes()){
            //读取消息长度小于传过来的长度 重置读取位置
            in.resetReaderIndex();
            return;
        }

        byte[] content = new byte[length];
        in.readBytes(content);

        //封装成自定义的protocol对象
        BaseProtocol baseProtocol = new BaseProtocol();
        baseProtocol.setLen(length);
        baseProtocol.setContent(content);
        out.add(baseProtocol);

    }
}
