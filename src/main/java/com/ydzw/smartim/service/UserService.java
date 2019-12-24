package com.ydzw.smartim.service;

import com.ydzw.smartim.model.UserInfo;

import java.util.List;

public interface UserService {
    List<UserInfo> findAll();
    boolean queryUserIdIsExist(String userId);
    int saveUser(UserInfo userInfo);

    UserInfo queryUserForLogin(String userId, String password);
}
