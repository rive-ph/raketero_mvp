import React, { Component } from "react";

import {
  StyleSheet,
  Text,
  View,
  TextInput,
  TouchableOpacity,
  ImageBackground,
  Image,
  StatusBar,
  AsyncStorage
} from "react-native";


import { loginbg } from "../assets";



export default class Login extends Component {
  state = {
    email: "",
    password: ""
  };
  constructor(props) {
    super(props);
  }


  onAuthenticated = async () => {
    await AsyncStorage.setItem("userToken", 'hello');
    this.props.navigation.navigate('App');
  };

  render() {
    return (
      <ImageBackground
        source={require("../assets/loginbg.jpg")}
        style={styles.container}
      >
      <StatusBar hidden />
        <Image
          source={require("../assets/logo.png")}
          style={{ width: "60%", height: 150 }}
        />
        <View style={styles.inputView}>
          <TextInput
            style={styles.inputText}
            placeholder="User Name"
            placeholderTextColor="#BDBDBD"
            onChangeText={text => this.setState({ email: text })}
          />
        </View>
        <View style={styles.inputView}>
          <TextInput
            secureTextEntry
            style={styles.inputText}
            placeholder="Password"
            placeholderTextColor="#BDBDBD"
            onChangeText={text => this.setState({ password: text })}
          />
        </View>
        <TouchableOpacity>
          <Text style={styles.forgot}>Forgot Password?</Text>
        </TouchableOpacity>
        <TouchableOpacity
          style={styles.loginBtn}
          onPress={() => {
            this.onAuthenticated({
              userName: this.state.email,
              password: this.state.password
            });
          }}
        >
          <Text style={styles.loginText}>LOGIN</Text>
        </TouchableOpacity>
        <TouchableOpacity style={styles.signUpBtn}>
          <Text style={styles.loginText}>Signup</Text>
        </TouchableOpacity>
      </ImageBackground>
    );
  }
}

const styles = StyleSheet.create({
  backgroundImage: {
    flex: 1,
    resizeMode: "cover" // or 'stretch'
  },
  container: {
    flex: 1,
    backgroundColor: "#003f5c",
    alignItems: "center",
    justifyContent: "center"
  },
  logo: {
    fontWeight: "bold",
    fontSize: 50,
    color: "#fb5b5a",
    marginBottom: 40
  },
  inputView: {
    width: "80%",
    backgroundColor: "#465881",
    borderRadius: 25,
    height: 50,
    marginTop: 20,
    marginBottom: 20,
    justifyContent: "center",
    padding: 20
  },
  inputText: {
    height: 50,
    color: "white"
  },
  forgot: {
    color: "white",
    fontSize: 14
  },
  loginBtn: {
    width: "80%",
    backgroundColor: "#FF9800",
    borderRadius: 25,
    height: 50,
    alignItems: "center",
    justifyContent: "center",
    marginTop: 10,
    marginBottom: 5
  },
  signUpBtn: {
    width: "80%",
    backgroundColor: "#fafafa",
    borderRadius: 25,
    height: 50,
    alignItems: "center",
    justifyContent: "center",
    marginTop: 5,
    marginBottom: 5
  }
});
