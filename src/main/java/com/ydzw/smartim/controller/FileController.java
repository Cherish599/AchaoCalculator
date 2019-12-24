package com.ydzw.smartim.controller;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.ydzw.smartim.constant.FileConstants;
import org.apache.commons.io.FileUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.multipart.MultipartFile;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.*;
import java.net.URLDecoder;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.Map;
import java.util.UUID;

@Controller
@RequestMapping("/file")
public class FileController {

    @Autowired
    private ObjectMapper objectMapper;

    @RequestMapping(value = "/upload",method = RequestMethod.POST)
    @ResponseBody
    public String upload(@RequestParam("file") MultipartFile multipartFile) throws JsonProcessingException, UnsupportedEncodingException {
        Map<String,Object> returnMap = new HashMap<>();
        if(!multipartFile.isEmpty()){
            String originalFilename = multipartFile.getOriginalFilename();
            File file = new File(FileConstants.IMAGE_PATH);
            if(!file.exists()){
                file.mkdir();
            }
//            String fileName = UUID.randomUUID().toString().replace("-", "");
//            originalFilename = fileName + "_" + originalFilename;

            try {
                multipartFile.transferTo(new File(FileConstants.IMAGE_PATH+originalFilename));
                returnMap.put("state", FileConstants.UPLOAD_SUCCESS);
                returnMap.put("filename",originalFilename);
            } catch (IOException e) {
                returnMap.put("state",FileConstants.UPLOAD_FAIL);
                e.printStackTrace();
            }
        }else {
            returnMap.put("state",FileConstants.UPLOAD_FAIL);
        }
        return objectMapper.writeValueAsString(returnMap);
    }


    @RequestMapping(value = "/uploads",method = RequestMethod.POST)
    @ResponseBody
    public String insertMoreNotice(@RequestParam("file") MultipartFile[] multipartFile) throws JsonProcessingException {
        Map<String,Object> returnMap = new HashMap<>();
        File file = new File(FileConstants.IMAGE_PATH);
        for(int i = 0;i < multipartFile.length;i++){
            try {
                if(!multipartFile[i].isEmpty()){
                    String originalFilename = multipartFile[i].getOriginalFilename();
                    System.out.println(originalFilename);
                    if(!file.exists()){
                        file.mkdir();
                    }
                    String fileName = UUID.randomUUID().toString().replace("-", "");
                    originalFilename = fileName + "_" + originalFilename;
                    multipartFile[i].transferTo(new File(FileConstants.IMAGE_PATH+originalFilename));
                    returnMap.put("state", "1");
                }
            } catch (IOException e) {
                returnMap.put("state","0");
                e.printStackTrace();
            }
        }

        return objectMapper.writeValueAsString(returnMap);
    }

    @RequestMapping("/download")
    @ResponseBody
    public ResponseEntity<byte[]> downloadFile(@RequestParam("filename") String filename){

        //构建file
        System.out.println("filename = " + filename);
        File file = new File(FileConstants.IMAGE_PATH + filename);
        //ok为状态200
        ResponseEntity.BodyBuilder builder = ResponseEntity.ok();
        //内容长度
        builder.contentLength(file.length());
        builder.contentType(MediaType.APPLICATION_OCTET_STREAM);
        byte[] bytes = null;
        try {
            filename = URLEncoder.encode(filename,"utf-8");
            builder.header("Content-Disposition","attachment; filename=" + filename);
            bytes = new byte[0];
            bytes = FileUtils.readFileToByteArray(file);
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return builder.body(bytes);
    }


    //文件下载相关代码
    @RequestMapping("/downloadFile")
    public String downloadFile(HttpServletRequest request, HttpServletResponse response, @RequestParam("filename") String filename) {
        if (filename != null) {
            //设置文件路径
            String filePath = "F:/images/";
            File file = new File(filePath , filename);
            if (file.exists()) {
                response.setContentType("application/octet-stream");//
                response.setHeader("content-type", "application/octet-stream");
                response.setHeader("Content-Disposition", "attachment;fileName=" + filename);// 设置文件名
                byte[] buffer = new byte[1024];
                FileInputStream fis = null;
                BufferedInputStream bis = null;
                try {
                    fis = new FileInputStream(file);
                    bis = new BufferedInputStream(fis);
                    OutputStream os = response.getOutputStream();
                    int i = bis.read(buffer);
                    while (i != -1) {
                        os.write(buffer, 0, i);
                        i = bis.read(buffer);
                    }
                    System.out.println("success");
                } catch (Exception e) {
                    e.printStackTrace();
                } finally {
                    if (bis != null) {
                        try {
                            bis.close();
                        } catch (IOException e) {
                            e.printStackTrace();
                        }
                    }
                    if (fis != null) {
                        try {
                            fis.close();
                        } catch (IOException e) {
                            e.printStackTrace();
                        }
                    }
                }
            }
        }
        return null;
    }

}
