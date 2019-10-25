const express = require('express');
const oConn = require('./repositories/connection');

const app = express();

const testController = require('./controllers/test-controller');
app.use(testController);

const port = process.env.PORT || 4000;

app.listen({port}, async () => {
    //await oConn.init();
    console.log(`Server running at http://localhost:${port}`);
});
