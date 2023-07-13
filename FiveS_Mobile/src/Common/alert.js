import { Alert } from 'react-native'
import React from 'react'

const showAlert = (messageHeader, messageBody, messageButton,) => {
    Alert.alert(
        messageHeader,
        messageBody,
        [
            { text: messageButton, onPress: () => console.log("Tamam''a basıldı") }
        ],
        { cancelable: false }
    );
}

export { showAlert }