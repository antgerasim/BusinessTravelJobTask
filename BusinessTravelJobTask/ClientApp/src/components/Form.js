import React, { Component } from 'react';

export class Form extends Component {

    constructor(props) {
        super(props);

        this.state = {
            dateFrom: '',//текущая дата + 1 месяц
            dateTo: '', //«дата с» + 2 недели
            isGoing: true,
            countries: [],
            cities: [],
            selectedCity: 1,
            selectedCountry: 29
        };

        //console.log(this.state);
        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {

        var apiUrl = 'api/TravelData/Filter';
        console.log(apiUrl);

        fetch(apiUrl)
            .then(response => response.json())
            .then(json => {

                var countries = json.data.dictionaries.countries;
                var cities = json.data.dictionaries.departureCities;
                var dateFromObj = this.convertDateFrom(1);
                var dateToObj = this.convertDateTo(dateFromObj, 2);

                this.setState({
                    countries: countries,
                    cities: cities,
                    dateFrom: this.dateToString(dateFromObj),
                    dateTo: this.dateToString(dateToObj)
                });

                console.log(this.state);
            });
            
    }

    convertDateFrom(nMonth) {
        var today = new Date();
        var todayPlusNMonth = new Date(today.setMonth(today.getMonth() + nMonth));
        return todayPlusNMonth;
    }

    convertDateTo(dateFrom, nWeeks) {
        var dateToPlusNWeeks = new Date(dateFrom.getTime() + (6.04e+8 * nWeeks));
        return dateToPlusNWeeks;
    }

    dateToString(date) {
        return date.toISOString().substr(0, 10);
    }

    handleSubmit(e) {        
        console.log(this.props.name);
        this.props.getSearchResult(e, this.state.selectedCity, this.state.selectedCountry,
            this.state.dateFrom, this.state.dateTo);
    }

    handleInputChange(event) {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        this.setState({
            [name]: value
        });
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>
                    Город вылета:
                    <select name="selectedCity" value={this.state.selectedCity} onChange={this.handleInputChange}>
                        {this.state.cities.map((city, index) =>
                            < option key={index} value={city.id} >
                                {city.name}
                            </option>)}
                    </select>
                </label>
                <label>
                    Страна прибывания:
                    <select name="selectedCountry" value={this.state.selectedCountry} onChange={this.handleInputChange}>
                        {this.state.countries.map((country, index) =>
                            <option key={index} value={country.id}>
                                {country.name}
                            </option>)}
                    </select>
                </label>
                <label>
                    Дата с:
               <input type="date" name="dateFrom" value={this.state.dateFrom} onChange={this.handleInputChange} />
                </label>
                <label>
                    Дата по:
              <input type="date" name="dateTo" value={this.state.dateTo} onChange={this.handleInputChange} />
                </label>
                <input type="submit" value="Поиск" />
            </form >
        );
    }
}