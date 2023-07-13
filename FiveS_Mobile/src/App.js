import React, { Text } from 'react';

import AuditSettingsScreen from '../src/Screens/Audit/AuditSettings/AuditSettingsScreen'
import AuditsScreen from '../src/Screens/Audit/Audits/AuditsScreen'
import CreateAuditScreen from '../src/Screens/Audit/CreateAudit/CreateAuditScreen'
import DenemeScreen from './Deneme/DenemeScreen'
import HomeAdminScreen from '../src/Screens/Home/HomeAdmin/HomeAdminScreen'
import HomeOtherScreen from '../src/Screens/Home/HomeOthers/HomeOthersScreen'
import LoginScreen from './Screens/Login/LoginScreen'
import { NavigationContainer } from '@react-navigation/native';
import { SafeAreaView } from 'react-native-safe-area-context';
import UserProvider from '../src/Redux/Provider'
import { createNativeStackNavigator } from '@react-navigation/native-stack';

const Stack = createNativeStackNavigator();

function App() {
  return (
    <SafeAreaView>
      <Text>Merhaba</Text>
    </SafeAreaView>
    // <UserProvider>
    //   <NavigationContainer>
    //     <Stack.Navigator initialRouteName='Login'>
    //       {/* Deneme */}
    //       <Stack.Screen name="Deneme" component={DenemeScreen} />
    //       {/* Login */}
    //       <Stack.Screen name="Login" component={LoginScreen} />
    //       {/* Home */}
    //       <Stack.Screen name="HomeAdmin" component={HomeAdminScreen} />
    //       <Stack.Screen name="HomeOthers" component={HomeOtherScreen} />
    //       {/* Create-Audit */}
    //       <Stack.Screen name="CreateAudit" component={CreateAuditScreen} />
    //       {/* Audits */}
    //       <Stack.Screen name="Audits" component={AuditsScreen} />
    //       {/* Audit-Settings */}
    //       <Stack.Screen name="AuditSettings" component={AuditSettingsScreen} />
    //     </Stack.Navigator>
    //   </NavigationContainer>
    // </UserProvider>
  );
}

export default App;