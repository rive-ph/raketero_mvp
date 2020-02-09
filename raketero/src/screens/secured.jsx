import React, { Component } from "react";

import { ScrollView, Text, View, Button } from "react-native";

export default class Secured extends Component {
  constructor(props) {
    super(props);
  }

  render() {
    return (
      <ScrollView style={{ padding: 20, marginTop: 50 }}>
        <Text style={{ fontSize: 27 }}>Welcome</Text>
        <View style={{ margin: 20 }} />
        <Button onPress={()=>{
            this.props.navigation.push("Login")
        }} title="Logout" />
      </ScrollView>
    );
  }
}
