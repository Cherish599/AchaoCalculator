package com.ydzw.smartim.controller;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.ydzw.smartim.constant.UserConstants;
import com.ydzw.smartim.model.UserInfo;
import com.ydzw.smartim.service.UserService;
import com.ydzw.smartim.util.MD5Utils;
import org.apache.commons.lang3.StringUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/user")
public class UserController {

    @Autowired
    private UserService userService;

    @Autowired
    private ObjectMapper objectMapper;

    @RequestMapping("/findAll")
    @ResponseBody
    public List<UserInfo> findAllUser(){
        return userService.findAll();
    }


    @RequestMapping("/login")
    @ResponseBody
    public String login(@RequestBody UserInfo user) throws Exception {
        //判断用户名和密码不能为空
        if (StringUtils.isBlank(user.getUserId())
                || StringUtils.isBlank(user.getUserPassword())) {
            return objectMapper.writeValueAsString(UserConstants.USERNAME_OR_PASSWORD_IS_NULL);
        }

        UserInfo userResult = userService.queryUserForLogin(user.getUserId(),
                MD5Utils.getMD5Str(user.getUserPassword()));
        if (userResult == null) {
            return objectMapper.writeValueAsString(UserConstants.USERNAME_OR_PASSWORD_IS_ERROR);
        }
        return objectMapper.writeValueAsString(userResult);
    }

    @RequestMapping(value = "/register",method = RequestMethod.POST)
    @ResponseBody
    public String register(@RequestBody UserInfo user) throws Exception {
        boolean userIdIsExist = userService.queryUserIdIsExist(user.getUserId());
        if (!userIdIsExist) {
            // 注册
            user.setUserPassword(MD5Utils.getMD5Str(user.getUserPassword()));
            user.setIdReviewestatus(0);
            userService.saveUser(user);
        } else {
            return objectMapper.writeValueAsString(UserConstants.USER_IS_EXIST);
        }
        return objectMapper.writeValueAsString(UserConstants.USER_SUCCESS_REGISTER);
    }




}
