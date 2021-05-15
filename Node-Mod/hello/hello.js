const self = exports;

exports.say = function () {
    console.log("Hello, world");
};

exports.sayNtimes = (n) => {
    for (let i = 0; i < n; i++) {
        self.say();
    }
};

function bye() {
    console.log("Good-bye");
}
