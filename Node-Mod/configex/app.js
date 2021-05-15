const config = require("config");
const { dac, hello } = require("common");

const conn = config.get("connect");
console.log(conn.server);

hello.say();
dac.user.list();
//console.log(util.date.fmt(new Date()));
