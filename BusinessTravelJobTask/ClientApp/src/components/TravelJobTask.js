import React, { Component } from 'react';

import { Constants } from '../Constants.js';
import { Form } from './Form';
import { SearchResult } from './SearchResult';

export class TravelJobTask extends Component {

    constructor(props) {
        super(props);

        this.state = {
            error: null,
            isLoaded: true,
            items: []
        };
        //console.log(this.props);
    }
    getSearchResult = (e, cityId, countryId, dateFrom, dateTo) => {
        e.preventDefault();

        //Search endpoint: https://api2.mouzenidis.com/search?departureCities[0]=1&countries[0]=29&dateFrom=2020-02-19&dateTo=2020-02-22&nights[0]=6&nights[1]=7&nights[2]=8&nights[3]=9&nights[4]=10
        var url = `${Constants.searchAPIUrl}departureCities[0]=${cityId}&countries[0]=${countryId}&dateFrom=${dateFrom}&dateTo=${dateTo}&${Constants.nightsTailAPIUrl}`;
        var apiUrl = `api/traveldata/search?cityId=${cityId}&countryId=${countryId}&dateFrom=${dateFrom}&dateTo=${dateTo}`;
        console.log(apiUrl);

        this.setState({
            isLoaded: false,
        });

        fetch(apiUrl)
            .then(res => 
               // console.log(res);
                res.json()
            )
            .then(
            (travelDataResult) => {

                console.log(travelDataResult);

                    this.setState({
                        isLoaded: true,
                        items: travelDataResult.data
                    });
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            );
    }

    render() {
        const { error, isLoaded, items } = this.state;
        return (
            <div>
                <h1>Travel Job Task</h1>
                <Form getSearchResult={this.getSearchResult}></Form>
                <SearchResult items={items} isLoaded={isLoaded} error={error}></SearchResult>
            </div>
        );
    }
}