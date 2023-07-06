// function to convert CSV to JSON and XML
const fs = require("fs");
const csv = require("csv-parser");
const json2xml = require("json2xml");

// function to convert csv to JSON
function csvToJson(path) {
  return new Promise((resolve, reject) => {
    fs.createReadStream(path)
      .pipe(csv())
      .on("data", (data) => {
        resolve(data);
      })
      .on("error", (err) => {
        reject(err);
      });
  });
}
// function to convert csv to XML

function csvToXml(path) {
  return new Promise((resolve, reject) => {
    const results = [];
    fs.createReadStream(path)
      .pipe(csv())
      .on("data", (data) => {
        results.push(data);
      })
      .on("end", () => {
        resolve(JSON.stringify(results));
      })
      .on("error", (err) => {
        reject(err);
      });
  });
}
