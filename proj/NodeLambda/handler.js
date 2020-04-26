'use strict';

const AWS = require("aws-sdk");
const uuid = require("uuid/v4");
const Jimp = require("jimp");
const s3 = new AWS.S3();
const width = 200;
const height = 200;
const imageType = "image/png";
const bucket = process.env.Bucket;


module.exports.helloWorld = (event, context, callback) => {
  console.log(`Testowy log z HelloWorld`);

  const response = {
    statusCode: 200,
    headers: {
      'Access-Control-Allow-Origin': '*', // Required for CORS support to work
    },
    body: JSON.stringify({
      message: 'Test message number uno',
//      input: event,
    }),
  };

  callback(null, response);
};


module.exports.uploadImage = (event, context, callback) => {
    let requestBody = JSON.parse(event.body);
    let photoUrl = requestBody.photoUrl;
    let objectId = uuid();
    let objectKey = `resize-${width}x${height}-${objectId}.png`;

    fetchImage(photoUrl)
        .then(image => image.resize(width, height)
            .getBufferAsync(imageType))
        .then(resizedBuffer => uploadToS3(resizedBuffer, objectKey))
        .then(function(response) {
            console.log(`Image ${objectKey} was uploaded and resized`);
            callback(null, {
                statusCode: 200,
                body: JSON.stringify(response)
            });
        })
        .catch(error => console.log(error));
};

/**
* @param {*} data
* @param {string} key
*/
function uploadToS3(data, key) {
    return s3
        .putObject({
            Bucket: bucket,
            Key: key,
            Body: data,
            ContentType: imageType
        })
        .promise();
}

/**
* @param {url}
* @returns {Promise}
*/
function fetchImage(url) {
    return Jimp.read(url);
}
