const fs = require("fs");
const path = require("path");

const basePath = "data";
try {
    const files = fs.readdirSync(basePath);
    for (let file of files) {
        try {
            const res = fs.readFileSync(path.join(basePath, file));
            console.log(file);
            console.log(JSON.stringify(JSON.parse(res), null, 4));
        } catch (err) {
            console.error(err);
        }
    }
} catch (err) {
    console.error(err);
}
