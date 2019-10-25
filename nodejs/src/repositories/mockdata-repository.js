const oConn = require('./connection');
const oracledb = require('oracledb');

module.exports = {
    async getAllByIdSearchAsync(idSearch) {
        const conn = await oConn.getConnection();

        const sql = `SELECT * FROM mock.mockdata WHERE id_search = :idSearch`;
        const binds = [idSearch];
        const options = { outFormat: oracledb.OUT_FORMAT_OBJECT };
        const result = await conn.execute(sql, binds, options);
        conn.close();
        return result.rows;
    }
};
