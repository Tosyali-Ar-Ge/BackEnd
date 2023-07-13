import * as actionTypes from '../../../Redux/actionTypes'

import {
    Button,
    Text,
    View,
} from 'react-native'
import React, { useState } from 'react';

import { SafeAreaView } from 'react-native-safe-area-context'
import homeAdminStyles from './HomeAdminStyles'
import { useSelector } from 'react-redux';

function HomeAdminScreen({ navigation }) {
    const storeUser = useSelector(s => s.user)

    const [user, setUser] = useState();

    //#region Functions
    const createAudit = () => {
        // console.log(store.getState())
        // navigation.navigate('CreateAudit');
    }
    const audits = () => {
        navigation.navigate('Audits');
    }
    const auditSettings = () => {
        navigation.navigate('AuditSettings');
    }
    //#endregion
    return (
        <SafeAreaView style={{ flex: 1 }}>
            <View style={homeAdminStyles.topView}>
                <Text>{" Hoşgeldin Admin " + storeUser.Name + " : " + storeUser.Role}</Text>
            </View>
            <View style={homeAdminStyles.buttonView}>
                <Button
                    onPress={createAudit}
                    title="Denetim Oluştur"
                    style={homeAdminStyles.buttonCreateAudit}
                />
                <Button
                    onPress={audits}
                    title="Denetimler"
                    style={homeAdminStyles.buttonAudits}
                />
                <Button
                    onPress={auditSettings}
                    title="Denetim Ayarları"
                    style={homeAdminStyles.auditßSettings}
                />
            </View>
            <View style={homeAdminStyles.bottomView}>

            </View>
        </SafeAreaView>
    )
}

export default HomeAdminScreen