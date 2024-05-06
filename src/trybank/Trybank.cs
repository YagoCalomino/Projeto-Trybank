namespace Trybank.Lib;

public class TrybankLib
{
    public bool Logged;
    public int loggedUser;

    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;

    public TrybankLib()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    // 1. Construa a funcionalidade de cadastrar novas contas
    public void RegisterAccount(int number, int agency, int pass)
    {
    int index = 0;
    while (index < registeredAccounts)
    {
        if (Bank[index, 0] == number && Bank[index, 1] == agency)
        {
            throw new ArgumentException("A conta já está sendo usada!");
        }
        index++;
    }
    if (registeredAccounts >= maxAccounts)
    {
        throw new InvalidOperationException("Limite máximo de contas alcançado.");
    }
    Bank[registeredAccounts, 0] = number;
    Bank[registeredAccounts, 1] = agency;
    Bank[registeredAccounts, 2] = pass;  
    Bank[registeredAccounts, 3] = 0; 
    registeredAccounts++;
    }

    // 2. Construa a funcionalidade de fazer Login
    public void Login(int number, int agency, int pass)
    {
        if(Logged){
            throw new AccessViolationException("Usuário já está logado");
        }
        int index = 0;
        while (index < registeredAccounts)
        {
            if (Bank[index, 0] == number && Bank[index, 1] == agency && Bank[index, 2] != pass)
            {
                throw new ArgumentException("Senha incorreta");
            }

            if ((Bank[index, 0] == number && Bank[index, 1] == agency) == false)
            {
                throw new ArgumentException("Agência + Conta não encontrada");
            }
            if (Bank[index, 0] == number && Bank[index, 1] == agency && Bank[index, 2] == pass)
            {
            Logged = true;
            loggedUser = index;
            }
            index++;
        }
    }

    // 3. Construa a funcionalidade de fazer Logout
    public void Logout()
    {
        if(!Logged){
            throw new AccessViolationException("Usuário não está logado");
        }
        if(Logged){
            Logged = false;
            loggedUser = (loggedUser > 0) ? loggedUser - 1 : 0;
        }
    }

    // 4. Construa a funcionalidade de checar o saldo
        public int CheckBalance()
        {
        if(!Logged){
            throw new AccessViolationException("Usuário não está logado");
        }  
        return Bank[loggedUser, 3];  
    }

    // 5. Construa a funcionalidade de depositar dinheiro
    public void Deposit(int value)
    {
        if(!Logged){
            throw new AccessViolationException("Usuário não está logado");
        }  
        Bank[loggedUser, 3] = Bank[loggedUser, 3] + value;
    }

    // 6. Construa a funcionalidade de sacar dinheiro
    public void Withdraw(int value)
    {
        if(!Logged){
            throw new AccessViolationException("Usuário não está logado");
        };
        Bank[loggedUser, 3] -= value;
        if( Bank[loggedUser, 3] < 0 ){
            Bank[loggedUser, 3] += value;
            throw new InvalidOperationException("Saldo insuficiente");
        }
    }

    // 7. Construa a funcionalidade de transferir dinheiro entre contas
    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        if(!Logged){
            throw new AccessViolationException("Usuário não está logado");
        };
        Bank[loggedUser, 3] -= value;
        if( Bank[loggedUser, 3] < 0 ){
            Bank[loggedUser, 3] += value;
            throw new InvalidOperationException("Saldo insuficiente");
        }
        for (int i = 0; i < registeredAccounts; i++)
        {
            if (Bank[i, 0] == destinationNumber && Bank[i, 1] == destinationAgency)
            {
            double temp = Bank[i,3];
            Bank[i,3] += value;
            if(Bank[i,3] < temp){
                throw new InvalidOperationException("Operação inválida");
            }
            }
        }
    }

   
}
