package com.firstdata.perftest.services;

import com.firstdata.perftest.domain.MockData;
import com.firstdata.perftest.repositories.MockDataRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class MockDataService {
    @Autowired
    private MockDataRepository mockDataRepository;

    public List<MockData> findAllByIdSearch(int idSearch, int type) {
        switch (type) {
            case 1:
            default:
                return mockDataRepository.findAllByIdSearch(idSearch);
            case 2:
                return mockDataRepository.findAllByIdSearchNative(idSearch);
            case 3:
                return mockDataRepository.findAllByIdSearchJdbc(idSearch);
        }
    }
}
