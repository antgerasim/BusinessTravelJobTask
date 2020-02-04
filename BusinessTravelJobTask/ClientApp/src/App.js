import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { TravelJobTask } from './components/TravelJobTask';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
            <Route exact path='/' component={TravelJobTask} />

            {/* <Route path='/counter' component={Counter} />
            <Route path='/fetchdata' component={FetchData} />*/}

            <Route path='/traveljobtask' component={TravelJobTask} />

      </Layout>
    );
  }
}
