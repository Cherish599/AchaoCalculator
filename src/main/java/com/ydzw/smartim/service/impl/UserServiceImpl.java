package com.ydzw.smartim.service.impl;

import com.ydzw.smartim.mapper.UserInfoMapper;
import com.ydzw.smartim.model.UserInfo;
import com.ydzw.smartim.model.UserInfoExample;
import com.ydzw.smartim.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import tk.mybatis.mapper.entity.Example;

import java.util.List;

@Service
public class UserServiceImpl implements UserService {

    @Autowired
    private UserInfoMapper userInfoMapper;

    @Override
    public List<UserInfo> findAll() {
        UserInfoExample example = new UserInfoExample();
        return userInfoMapper.selectByExample(example);
    }

    @Override
    public boolean queryUserIdIsExist(String userId) {
        UserInfo userInfo = userInfoMapper.selectByPrimaryKey(userId);
        return userInfo != null ? true : false;
    }

    @Override
    public int saveUser(UserInfo userInfo) {
        return userInfoMapper.insertSelective(userInfo);
    }

    @Override
    public UserInfo queryUserForLogin(String userId, String password) {
        UserInfoExample example = new UserInfoExample();
        UserInfoExample.Criteria criteria = example.createCriteria();
        criteria.andUserIdEqualTo(userId).andUserPasswordEqualTo(password);

        List<UserInfo> userInfos = userInfoMapper.selectByExample(example);
        if(userInfos.isEmpty()){
            return null;
        }else {
            return userInfos.get(0);
        }
    }
}
