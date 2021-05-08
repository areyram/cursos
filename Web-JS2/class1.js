class User {
    constructor(id, name) {
        this.id = id;
        this.name = name;
    }
    getCode() { return "USR" + this.id; }
}

const user = new User(1, "johndoe");
user.date = new Date();
console.log(JSON.stringify(user));
console.log(user.getCode());
