import {
  createStackNavigator,
} from "react-navigation-stack";

import { createAppContainer ,createSwitchNavigator} from "react-navigation";
import Login from "../src/screens/login";
import Secured from "../src/screens/secured";

import AuthLoadingScreen from "../src/components/AuthLoadingScreen";

const SecuredScreens = {
  Secured: {
    screen: Secured,
    navigationOptions: {
        headerShown: false,
    },
  }
};

const AuthScreens = {
  Login: {
    screen: Login,
    navigationOptions: {
        headerShown: false,
    },
  }
};

const SecuredStack = createStackNavigator(SecuredScreens);
const AuthStack = createStackNavigator(AuthScreens);

export default createAppContainer(
  createSwitchNavigator(
    {
      AuthLoading: AuthLoadingScreen,
      App: SecuredStack,
      Auth: AuthStack
    },
    {
      initialRouteName: "AuthLoading",
      
    }
  )
);
