package com.firstdata.perftest.repositories;

import com.firstdata.perftest.domain.MockData;

import java.util.List;

public interface MockDataRepositoryCustom {
    List<MockData> findAllByIdSearchJdbc(int idSearch);
}
