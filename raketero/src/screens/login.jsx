import React, { Component } from "react";

import { ScrollView,TextInput, Text,View, Button ,Image } from "react-native";

export default class Login extends Component {
  render() {
    return (
            <ScrollView style={{padding: 20, alignContent:"center"}}>
                <Text 
                    style={{fontSize: 27}}>
                    Login
                </Text>
                <TextInput placeholder='Username' />
                <TextInput placeholder='Password' />
                <View style={{margin:7}} />
                <Button 
                          onPress={this.props.onLoginPress}
                          title="Submit"
                      />
                  </ScrollView>
            )
  }
}
