import React, { Component, Fragment } from "react";

import Login from "./src/screens/login";

import { StyleSheet, Text, View } from "react-native";
import Secured from "./src/screens/secured";


export default class App extends Component {
  constructor(props){
    super(props);
    this.state = {
      authenticated : false
    }
  }
  render() {
    return (
      <Login />
    );
  }
}

