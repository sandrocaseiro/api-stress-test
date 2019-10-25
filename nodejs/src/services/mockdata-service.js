const mockdataRepo = require('../repositories/mockdata-repository');

module.exports = {
    getAllByIdSearchAsync(idSearch) {
        return mockdataRepo.getAllByIdSearchAsync(idSearch);
    }
};
