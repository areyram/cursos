const mysql = require("mysql");

const conn = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "admin",
});

conn.connect(function (err) {
    if (err) throw err;
    conn.query("SELECT * FROM city", function (err, result) {
        if (err) throw err;
        console.log("Result: " + result);
    });
});
