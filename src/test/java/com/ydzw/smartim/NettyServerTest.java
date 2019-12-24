package com.ydzw.smartim;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.ydzw.smartim.constant.UserConstants;
import com.ydzw.smartim.netty.protocol.ReceiveProtocol;
import com.ydzw.smartim.util.JsonUtils;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class NettyServerTest {

    @Test
    public void testEquals() throws JsonProcessingException {
        Map<String,String> map = new HashMap<>();
        ObjectMapper mapper = new ObjectMapper();
        map.put("filename","test.jpg");
        map.put("state","1");
        String string = mapper.writeValueAsString(map);
        System.out.println(string);
    }




    @Test
    public void testJson(){
        String msg = "{\"messageType\":\"single\",\"fromClient\":\"666\",\"toClient\":\"999\",\"message\":\"你好啊，netty\",\"roomId\":\"888\"}";

        System.out.println(msg);
        ReceiveProtocol receiveProtocol1 = JsonUtils.jsonToPojo(msg, ReceiveProtocol.class);

        System.out.println(receiveProtocol1);
    }


    @Test
    public void testListJson(){
        List<String> client = new ArrayList<>();
        client.add("888");
        client.add("999");
        ReceiveProtocol receiveProtocol = new ReceiveProtocol();
        receiveProtocol.setFromClient("777");
        receiveProtocol.setMessage("你好");
        receiveProtocol.setMessageType("single");
        receiveProtocol.setRoomId("r101");
        receiveProtocol.setToClient(client);

        String s = JsonUtils.objectToJson(receiveProtocol);
        System.out.println(s);


        ReceiveProtocol receiveProtocol1 = new ReceiveProtocol();
        receiveProtocol1.setFromClient("777");
        receiveProtocol1.setMessage("你好");
        receiveProtocol1.setMessageType("single");
        receiveProtocol1.setRoomId("r101");
        receiveProtocol1.setToClient(client);
        List<ReceiveProtocol> receiveProtocols = new ArrayList<>();
        receiveProtocols.add(receiveProtocol);
        receiveProtocols.add(receiveProtocol1);
        String s1 = JsonUtils.objectToJson(receiveProtocols);
        System.out.println(s1);

        String s2 = JsonUtils.objectToJson(UserConstants.USER_IS_EXIST);
        System.out.println(s2);

    }


}
