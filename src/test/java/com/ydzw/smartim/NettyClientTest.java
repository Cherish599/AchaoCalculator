package com.ydzw.smartim;

import com.ydzw.smartim.androidtest.UploadFille;
import com.ydzw.smartim.enumtype.MessageType;
import com.ydzw.smartim.netty.MessageDecoder;
import com.ydzw.smartim.netty.MessageEncoder;
import com.ydzw.smartim.netty.protocol.BaseProtocol;
import com.ydzw.smartim.netty.protocol.ReceiveProtocol;
import com.ydzw.smartim.util.JsonUtils;
import io.netty.bootstrap.Bootstrap;
import io.netty.channel.*;
import io.netty.channel.nio.NioEventLoopGroup;
import io.netty.channel.socket.SocketChannel;
import io.netty.channel.socket.nio.NioSocketChannel;
import io.netty.handler.codec.string.StringDecoder;
import io.netty.handler.codec.string.StringEncoder;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Scanner;

public class NettyClientTest {
    private Logger logger = LoggerFactory.getLogger(this.getClass());
    //属性
    private final String host;
    private final int port;

    public NettyClientTest(String host,int port){
        this.host = host;
        this.port = port;
    }

    public void run(){
        EventLoopGroup group = new NioEventLoopGroup();

        try {
            Bootstrap bootstrap = new Bootstrap()
                    .group(group)
                    .channel(NioSocketChannel.class)
                    .handler(new ChannelInitializer<SocketChannel>() {
                        @Override
                        protected void initChannel(SocketChannel socketChannel) throws Exception {
                            ChannelPipeline pipeline = socketChannel.pipeline();
                            pipeline.addLast("decoder",new MessageDecoder());
                            pipeline.addLast("encoder",new MessageEncoder());
                            //加入自定义的handler
                            pipeline.addLast(new ClientHandlerTest());
                        }
                    });

            ChannelFuture channelFuture = bootstrap.connect(host, port).sync();
            //得到channel
            Channel channel = channelFuture.channel();
            logger.info("----------------" + channel.localAddress() + "-------------");
            System.out.println("----------------" + channel.localAddress() + "-------------");
            //客户端需要输入信息，创建一个扫描器
            Scanner scanner = new Scanner(System.in);
            while (scanner.hasNextLine()){
                String msg = scanner.nextLine();
                BaseProtocol protocol = new BaseProtocol();
                byte[] bytes = msg.getBytes();
                protocol.setLen(bytes.length);
                protocol.setContent(bytes);
//                channel.writeAndFlush(bytes.length);
                channel.writeAndFlush(protocol);
                ReceiveProtocol receiveProtocol = JsonUtils.jsonToPojo(msg, ReceiveProtocol.class);
                if(MessageType.SINGLE_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                    UploadFille.upload();
                }
                if(MessageType.SINGLE_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                    UploadFille.upload();
                }
                if(MessageType.MEETING_IMAGE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                    UploadFille.upload();
                }
                if(MessageType.MEETING_FILE_TEXT.toString().equals(receiveProtocol.getMessageType())){
                    UploadFille.upload();
                }
            }

        } catch (InterruptedException e) {
            e.printStackTrace();
        }finally {
            group.shutdownGracefully();
        }

    }

    public static void main(String[] args) {
        new NettyClientTest("127.0.0.1",12345).run();
    }
}
