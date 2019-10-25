const express = require('express');
const router = express.Router();
const mockdataService = require('../services/mockdata-service');
const oConn = require('../repositories/connection');

router.get('/test/init', async (req, res, next) => {
    try {
        await oConn.init();
        res.send({
            resul: 'ok'
        });
    }
    catch (e) {
        next(e);
    }
});

router.get('/test/:idSearch', async (req, res, next) => {
    try {
        const result = await mockdataService.getAllByIdSearchAsync(req.params.idSearch);
        res.send(result.map(r => ({
            id: r.ID,
            email: r.EMAIL,
            firstName: r.FIRST_NAME,
            lastName: r.LAST_NAME,
            address: r.ADDRESS,
            city: r.CITY,
            identification: r.IDENTIFICATION,
            idSearch: r.ID_SEARCH
        })));
    }
    catch (e) {
        next(e);
    }
});

module.exports = router;
