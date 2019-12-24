package com.ydzw.smartim.netty;

import io.netty.channel.ChannelInitializer;
import io.netty.channel.ChannelPipeline;
import io.netty.channel.socket.SocketChannel;

public class ServerInitializer extends ChannelInitializer<SocketChannel> {
    @Override
    protected void initChannel(SocketChannel socketChannel) throws Exception {
        //获取到pipeline
        ChannelPipeline pipeline = socketChannel.pipeline();
        //向pipeline加入解码器
        pipeline.addLast("decoder",new MessageDecoder());
        //向pipeline中加入编码器
        pipeline.addLast("encoder",new MessageEncoder());

        //加入自己的业务处理handler
        pipeline.addLast(new ChatHandler());
    }
}
