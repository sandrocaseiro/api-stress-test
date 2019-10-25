package com.firstdata.perftest.repositories;

import com.firstdata.perftest.domain.MockData;
import org.springframework.stereotype.Repository;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;
import java.util.List;

@Repository
public class MockDataRepositoryImpl implements MockDataRepositoryCustom {
    @PersistenceContext
    private EntityManager entityManager;

    @Override
    public List<MockData> findAllByIdSearchJdbc(int idSearch) {
        Query query = entityManager.createNativeQuery("select * from Mock.MockData where id_search = :idSearch", MockData.class)
            .setParameter("idSearch", idSearch);

        return (List<MockData>)query.getResultList();
    }
}
