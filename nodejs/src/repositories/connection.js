const config = require('../config.json');
const oracledb = require('oracledb');

module.exports = {
    async init() {
        await oracledb.createPool(config.dbConfig);
    },
    getConnection() {
        return oracledb.getConnection(config.dbConfig.poolAlias);
    }
};
