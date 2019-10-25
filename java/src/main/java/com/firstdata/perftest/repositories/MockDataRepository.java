package com.firstdata.perftest.repositories;

import com.firstdata.perftest.domain.MockData;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface MockDataRepository extends JpaRepository<MockData, Long>, MockDataRepositoryCustom {
    @Query("from MockData where idSearch = :idSearch")
    List<MockData> findAllByIdSearch(int idSearch);

    @Query(value = "select * from Mock.MockData where id_Search = :idSearch", nativeQuery = true)
    List<MockData> findAllByIdSearchNative(int idSearch);
}
