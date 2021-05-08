const fs = require("fs");
const path = require("path");

const basePath = "data";
fs.readdir(basePath, (err, files) => {
    if (err) {
        console.error(err);
        return;
    }
    for (let file of files) {
        fs.readFile(path.join(basePath, file), (err, res) => {
            if (err) {
                console.error(err);
                return;
            }
            console.log(file);
            console.log(JSON.stringify(JSON.parse(res), null, 4));
        });
    }
});
