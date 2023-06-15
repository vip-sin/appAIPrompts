// create a exress server controller to read a csv file

const express = require("express");
const app = express();
const fs = require("fs");
const path = require("path");
const bodyParser = require("body-parser");

app.use(bodyParser.json());

app.use(express.static(path.join(__dirname, "public")));

app.get("/", (req, res) => {
  //use req to get the csv content from request body
  res.sendFile(path.join(__dirname, "public", "index.html"));
});

app.post("/upload", (req, res) => {
  console.log(req.body);
  res.sendFile(path.join(__dirname, "public", "index.html"));
});
