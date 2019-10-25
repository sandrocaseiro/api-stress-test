package com.firstdata.perftest.controllers;

import com.firstdata.perftest.domain.MockData;
import com.firstdata.perftest.services.MockDataService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping(produces = MediaType.APPLICATION_JSON_VALUE)
public class TestController {
    @Autowired
    private MockDataService mockDataService;

    @GetMapping("/test/{idSearch}")
    public List<MockData> findAllByIdSearch(@PathVariable int idSearch, @RequestParam(required = false, defaultValue = "1") int type) {
        return mockDataService.findAllByIdSearch(idSearch, type);
    }
}
