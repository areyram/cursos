function sleep(interval) {
    return new Promise((resolve, reject) => {
        setTimeout(() => resolve(interval), interval);
    });
};

async function main() {
    let res;
    res = await sleep(1000);
    console.log(res);
    res = await sleep(2000);
    console.log(res);
    res = await sleep(3000);
    console.log(res);
    res = await sleep(4000);
    console.log(res);
    console.log("Done");
}

main();