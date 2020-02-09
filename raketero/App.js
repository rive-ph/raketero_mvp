import React, { Component, Fragment } from "react";
import Navigator from "./routes/SecuredStack";
import Login from "./src/screens/login";


export default class App extends Component {
  constructor(props) {
    super(props);
  }



  render() {
    return <Navigator />;
  }
}
