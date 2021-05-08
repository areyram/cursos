function sleep(interval) {
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(interval), interval);
    });
};

sleep(1000).then(o => console.log(o));
sleep(2000).then(o => console.log(o));
sleep(3000).then(o => console.log(o));
sleep(4000).then(o => console.log(o));
console.log("Done");
