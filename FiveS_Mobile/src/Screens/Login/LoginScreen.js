import * as actionTypes from '../../Redux/actionTypes'

import { Box, Button, Icon, Input, NativeBaseProvider } from 'native-base'
import {
    Image,
    Text,
    TextInput,
    View
} from 'react-native'
import React, { useContext, useState } from 'react';

import Provider from '../../Redux/Provider';
import UserDtoForLogin from '../../Entities/Dtos/UserDtoForLogin'
import _styles from '../../Common/infrastructreStyles';
import loginStyles from './LoginStyles'
import { showAlert } from '../../Common/alert'
import { useDispatch } from 'react-redux'
import userService from '../../Services/userService';

function LoginScreen({ navigation }) {
    const store = useContext(Provider);
    dispatch = useDispatch();

    const [username, setUsername] = useState('')
    const [password, setPassword] = useState('')

    function takeLoggedUser(user) {
        dispatch({
            type: actionTypes.UPDATE_LOGGED_USER,
            payload: {
                Id: user.Id,
                Name: user.Name,
                CreatedDatetime: user.CreatedDatetime,
                Value: user.Value,
                Email: user.Email,
                Password: user.Password,
                Role: user.Role,
                Type: user.Type,
                CompanyRegistrationNumber: user.CompanyRegistrationNumber,
                Surname: user.Surname,
                UserName: user.UserName,
                ControlAreaREF: user.ControlAreaREF,
                FacilityREF: user.FacilityREF
            }
        });
    }
    const clearInputs = () => {
        setUsername('');
        setPassword('');
    }
    const handleLogin = async () => {
        const userDtoForLogin = new UserDtoForLogin(username, password);
        const loggedUser = await userService.login(userDtoForLogin);
        // console.log(loggedUser);

        if (loggedUser.Id > 0) {
            takeLoggedUser(loggedUser);

            console.log("Id 0 dan büyük")
            if (loggedUser.Role == 1) {
                clearInputs();
                navigation.navigate("HomeAdmin");
            }
            else if (loggedUser.Role == 2) {
                clearInputs();
                navigation.navigate("HomeOthers");
            }
            else {
                showAlert("Uyarı", "Kullanıcı yetkisi bulunamadı", "Tamam");
            }
        } else {
            showAlert("Uyarı", "Geçersiz kullanıcı.", "Tamam");
        }
    }
    const handleForgetPassword = () => {
        showAlert("Bu modül", "Yapım aşamasında..", "Tamam");
    }
    const handleUsernameChange = (text) => {
        setUsername(text);
    };
    const handlePasswordChange = (text) => {
        setPassword(text);
    };

    //#region Sections
    const TopSection = () => {
        return (
            <View style={loginStyles.appTopView} />

        );
    }
    const LogoSection = () => {
        return (
            <View style={loginStyles.companyLogoView}>
                <Image style={loginStyles.logoImage}
                    source={require("../../Assets/Logo-Tosyali.jpg")}
                />
                <Text style={loginStyles.logoText}>Tosyalı Holding</Text>
            </View>
        );
    }
    const InputSection = () => {

    }
    const ButtonSection = () => {
        return (
            <View style={loginStyles.buttonsView}>

                <Button
                    leftIcon={<Icon as={Ionicons} name="cloud-upload-outline" size="sm" />}

                >
                    Giriş Yap
                </Button>


                {/* <Button
                    style={loginStyles.loginButton}
                    title='Giriş Yap'
                    onPress={handleLogin}
                />
                <Box style={{ minHeight: 3 }}></Box>
                <Button
                    style={loginStyles.handleForgetPassword}
                    title='Şifremi Unuttum'
                    onPress={handleForgetPassword}
                /> */}
            </View>
        );
    }
    const BottomSection = () => {
        return (
            <View style={loginStyles.appBottomView} />
        );
    }
    //#endregion

    return (
        <NativeBaseProvider>
            <TopSection />
            <LogoSection />
            <Box style={loginStyles.userInputView}>
                <Input style={loginStyles.inputUsername}
                    variant="underlined"
                    value={username}
                    onChangeText={(text) => handleUsernameChange(text)}
                    placeholder="Kullanıcı Adı"
                    size="xl"
                />
                <Input style={loginStyles.inputPassword}
                    variant="underlined"
                    value={password}
                    onChangeText={(text) => handlePasswordChange(text)}
                    placeholder="Şifre"
                    size="xl"
                />
            </Box>
            {/* <InputSection /> */}
            <ButtonSection />
            <BottomSection />
        </NativeBaseProvider >
    )
}

export default LoginScreen