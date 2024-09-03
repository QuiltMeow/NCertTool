package com.meow.quilt.ncert.database.inserter;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import org.json.JSONObject;

public class Main {

    private static final String FILE_PATH = "DetailDataList.txt";

    public static void main(String[] args) {
        try {
            List<NoticeData> noticeDataList = parseNoticeDataJSON(FILE_PATH);
            insertToDatabase(noticeDataList);
            System.out.println("資料處理完成");
        } catch (IOException | SQLException ex) {
            System.err.println("發生例外狀況 : " + ex.getMessage());
        }
    }

    public static List<NoticeData> parseNoticeDataJSON(String fileName) throws IOException {
        List<NoticeData> ret = new ArrayList<>();
        List<String> jsonStringList = new ArrayList<>();
        try (FileInputStream fis = new FileInputStream(fileName)) {
            try (InputStreamReader isr = new InputStreamReader(fis)) {
                try (BufferedReader br = new BufferedReader(isr)) {
                    String line;
                    while ((line = br.readLine()) != null) {
                        if (line.isEmpty()) {
                            continue;
                        }
                        jsonStringList.add(line);
                    }
                }
            }
        }
        Collections.reverse(jsonStringList);

        for (String jsonString : jsonStringList) {
            JSONObject json = new JSONObject(jsonString);
            NoticeData data = new NoticeData();
            data.setReleaseId(json.getString("發布編號"));
            data.setReleaseTime(json.getString("發布時間"));
            data.setType(json.getString("事件類型"));
            data.setDetectTime(json.getString("發現時間"));
            data.setTitle(json.getString("通告名稱"));
            data.setContent(json.getString("內容說明"));
            data.setPlatform(json.getString("影響平台"));
            data.setLevel(json.getString("影響等級"));
            data.setSuggest(json.getString("建議措施"));
            data.setReference(json.getString("參考資料"));
            ret.add(data);
        }
        return ret;
    }

    public static void insertToDatabase(List<NoticeData> noticeDataList) throws SQLException {
        Connection connection = DatabaseConnection.getConnection();
        try (PreparedStatement ps = connection.prepareStatement("INSERT INTO `notice` (`release_id`, `release_time`, `type`, `detect_time`, `title`, `content`, `platform`, `level`, `suggest`, `reference`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)")) {
            for (NoticeData data : noticeDataList) {
                ps.setString(1, data.getReleaseId());
                ps.setString(2, data.getReleaseTime());
                ps.setString(3, data.getType());
                ps.setString(4, data.getDetectTime());
                ps.setString(5, data.getTitle());
                ps.setString(6, data.getContent());
                ps.setString(7, data.getPlatform());
                ps.setString(8, data.getLevel());
                ps.setString(9, data.getSuggest());
                ps.setString(10, data.getReference());
                ps.executeUpdate();
            }
        }
    }
}
