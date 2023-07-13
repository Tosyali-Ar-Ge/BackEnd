import { StyleSheet } from "react-native";

const colorsEnum = {
    loginTopView: '#00FFFF',
}

const flexEnum = {
    topFlex: 1,

    logoFlex: 3,
    inputFlex: 4,
    navigateFlex: 3,

    bottomFlex: 1,
}

const loginStyles = StyleSheet.create({
    /* Views */
    appTopView: {
        backgroundColor: '#FFFFFF',
        flex: flexEnum.topFlex,
        justifyContent: 'center',
        alignItems: 'center',
    },
    companyLogoView: {
        backgroundColor: '#FFFFFF',
        flex: flexEnum.logoFlex,
        justifyContent: 'center',
        alignItems: 'center',
    },
    userInputView: {
        flex: flexEnum.inputFlex,
        justifyContent: "center",
        alignItems: "center",
        backgroundColor: '#FFFFFF',
    },
    buttonsView: {
        flex: flexEnum.navigateFlex,
        justifyContent: "center",
        alignItems: "center",
        backgroundColor: '#FFFFFF',
    },
    appBottomView: {
        flex: flexEnum.bottomFlex,
        backgroundColor: '#FFFFFF',
    },
    // İnputs
    inputUsername: {
        maxWidth: 220,
    },
    inputPassword: {
        maxWidth: 220,
    },
    /* LOGO */
    logoImage: {

    },
    logoText: {
        fontSize: 30,
        color: 'red',
    },

    /* CONTROLS */
    loginButton: {
        padding: 20,
        margin: 20,
        fontSize: 40,
        height: 40,
        fontWeight: 40,
    },
    forgetPasswordButton: {
        padding: 20,
        margin: 20,
        fontSize: 40,
        height: 40,
        fontWeight: 40,
    }

    /* Texts */
});

export default loginStyles;