const path = require('path')
const fs = require('fs');
const grpc = require('grpc')
const protoLoader = require('@grpc/proto-loader')

const PROTO_PATH = path.join(__dirname, 'graphdefinitionservice.proto')
const packageDefinition = protoLoader.loadSync(PROTO_PATH, {
  keepCase: true,
  longs: String,
  enums: String,
  defaults: true,
  oneofs: true
})

// Load in our service definition
const graphdefinitionservice = grpc.loadPackageDefinition(packageDefinition).GraphDefinitionService;

const client = new graphdefinitionservice.GraphDefinitions('localhost:5001', grpc.credentials.createInsecure());
const getParams = 
{
    graphDefinitionId: 1
};
client.Get(getParams, function(err, response) {
  if (!err) {
    console.log(response);
  } else {
    console.log(err);
  }
});