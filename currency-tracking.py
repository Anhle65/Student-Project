import requests
import smtplib


def get_currency_status():
    api_key = "8YKT20RWYR84QME9"
    url = "https://www.alphavantage.co/query"

    parameters = {
        'function': "CURRENCY_EXCHANGE_RATE",
        "from_currency": "NZD",
        "to_currency": "VND",
        "apikey": api_key
    }
    response = requests.get(url, params=parameters)
    data = response.json()
    currency = data['Realtime Currency Exchange Rate']['5. Exchange Rate']
    date_and_time = data['Realtime Currency Exchange Rate']['6. Last Refreshed'].split()
    date = date_and_time[0]
    time = date_and_time[1]
    return f"The exchange rate is: {float(currency):.2f} \n The last time refreshed on {date} at {time} UTC"


def send_email(message):
    """send an email to notify the changes in currency"""
    user_mail = "levananh2358@gmail.com"
    password = 'frpppenewofwdwbv'
    connection = smtplib.SMTP("smtp.gmail.com", port=587)
    connection.starttls()
    connection.login(user=user_mail, password=password)
    connection.sendmail(from_addr=user_mail, to_addrs="levananh235813@gmail.com",
                        msg=f"Subject: The changes of currency now\n\n{message}")
    connection.close()


def main():
    message = get_currency_status()
    send_email(message)
    # This is for seeing the message sent to email
    print(message)


main()