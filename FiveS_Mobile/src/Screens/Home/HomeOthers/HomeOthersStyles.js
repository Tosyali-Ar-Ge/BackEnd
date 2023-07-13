import { StyleSheet } from "react-native";
const colorsEnum = {

}

const flexEnum = {
    topFlex: 2,
    buttonFlex: 1,
    bottomFlex: 2,
}

const styles = StyleSheet.create({
    topView: {
        flex: flexEnum.topFlex,
    },
    buttonView: {
        flex: flexEnum.buttonFlex,
        justifyContent: "space-between",
        alignSelf: "center",
        // backgroundColor: 'yellow',
    },
    bottomView: {
        flex: flexEnum.bottomFlex,
    },
    buttonCreateAudit: {

    },
    buttonAudits: {

    },
    auditSettings: {
    }
});

export default styles;