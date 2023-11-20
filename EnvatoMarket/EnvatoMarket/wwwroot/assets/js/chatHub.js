

$(document).ready(function () {
    $('#action_menu_btn').click(function () {
        $('.action_menu').toggle();
    });
    var users = $(".userCards");

    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub")
        .withAutomaticReconnect([1000, 2000, 3000, 5000])//0 2 10 30 cu saniyelerde connect olmaq isteyecek
        //eger connectde problem olsa nece saniye sonra tekrar connect olmaq isteyini bu formada yaza bileriy
        //ve bu funksiya baglanti var amma hansisa sebeblerden baglanti qopub bu halda istifade edilir
        .build();
    //connection.start();

    //baglanti hec qurulmayibsa costum funksiya yaziriq baglanti varken qopubsa withAutomaticReconnect() methodu
    //isleyecek yox eger hec yox idise costum yazdiqimiz start() methodu isleyecek

    /*
    3 event var:
    OnReconnecting()--baglanti qopub ve yeniden connect olmaq istiyir ve  olunmazdan evvel isleyen eventdir
    OnReconnected()--yeniden connect olandan  isleyen event
    OnClose()--connect olmaq proseslabsiz qaldiqda connect ola bilmedikde isleyen eventdire
    */

    async function start() {
        try {
            await connection.start();
        }
        catch (error) {
            setTimeout(() => {
                start(), 2000
            })
        }
    }
    start();
    users.click(function () {
        console.log(this)
        axios.get(`/Chat/UserMessage?userId=${this.id}`).then(data => {
            users.removeClass("active")
            $(this).addClass("active");
            $("#ChatMessageBody").html("");
            $("#ChatMessageBody").append(data["data"]);
            var messageInput = $("#messageInput");
            var fromId = $(this).attr("data-id");

            $("#sendMessage").click(() => {
                var message = messageInput.val();
                var toId = $("#sendMessage").attr("data-id");
                if (message.trim() != "") {
                    connection.invoke("SendMessageAsync", message, fromId, toId).catch(error => console.log(error));
                    const sendMessageData = {
                        Message: message,
                        FromUserId: fromId,
                        ToUserId: toId
                    };
                    axios.post('/Chat/SendMessage', sendMessageData)
                        .then(response => {
                            $("#ChatCardBody").append(response.data);
                        })
                        .catch(error => {
                            console.error('Error sending message:', error);
                        });

                    $("#messageInput").val("")
                }
            })
            messageInput.keyup(function () {
                connection.invoke("UserTyping", fromId);
            });
        })
    })
    connection.onreconnecting(error => {
        console.log(error)
    });
    connection.onreconnected(connectionId => {
        console.log(connectionId)
    });
    connection.onclose(connectionId => {
        console.log(connectionId)
    })

    connection.on("resieveMessage", (message, fromId, toId) => {
        const sendMessageData = {
            Message: message,
            FromUserId: fromId,
            ToUserId: toId
        };
        axios.post('/Chat/RecieveMessage', sendMessageData)
            .then(response => {
                $("#ChatCardBody").append(response.data);
            })
            .catch(error => {
                console.error('Error sending message:', error);
            });


    })
    connection.on("recieveTyping", function (userId) {
        $(`#${userId}Typing`).css("visibility", "visible");
        $(`#${userId}Typing1`).css("visibility", "visible");
        setTimeout(function () {
            $(`#${userId}Typing`).css("visibility", "hidden");
            $(`#${userId}Typing1`).css("visibility", "hidden");
        }, 2000)

    })
    connection.on("OnConnect", function (userId) {
        var element = $(`#${userId + "child"}`);
        $(`#${userId + "online"}>span`).html("online");
        element.removeClass("offline")
        var mainElement = $(`#${userId + "message"}`);
        mainElement.removeClass("offline")
    })
    connection.on("DisConnect", function (userId) {
        var element = $(`#${userId + "child"}`);
        $(`#${userId + "online"}>span`).html("ofline");
        element.addClass("offline")
        var mainElement = $(`#${userId + "message"}`);
        mainElement.addClass("offline")
    })

})
