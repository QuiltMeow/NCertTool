package com.meow.quilt.ncert.database.inserter;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DatabaseConnection {

    private static final int EXIT_FAILURE = 1;

    private static final String URL = "jdbc:mysql://127.0.0.1:4599/security";
    private static final String USER_NAME = "security";
    private static final String PASSWORD = "lfq6L0spHb4QkbUDXG6H_4g0N2ZFL2PHx22qlHwp";

    static {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
        } catch (ClassNotFoundException ex) {
            System.err.println("缺少函式庫 : " + ex.getMessage());
            System.exit(EXIT_FAILURE);
        }
    }

    public static Connection getConnection() throws SQLException {
        return DriverManager.getConnection(URL, USER_NAME, PASSWORD);
    }
}
