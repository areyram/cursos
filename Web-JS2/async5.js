function sleep(interval) {
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(interval), interval);
    });
};

Promise.all([
    sleep(1000).then(o => console.log(o)),
    sleep(4000).then(o => console.log(o)),
    sleep(2000).then(o => console.log(o)),
    sleep(3000).then(o => console.log(o))
])
    .then(() => console.log("Done"))
    .catch(err => console.log(err));
