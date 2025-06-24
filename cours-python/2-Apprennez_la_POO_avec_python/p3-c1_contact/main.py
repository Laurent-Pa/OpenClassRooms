"""Point d'entrée"""

from contact.user import User
from contact.textcontact import TextContactSystem
from contact.owlcontact import OwlContactSystem

def main():
    """Main function."""
    alice = User("Alice", TextContactSystem("0102030405"))
    bob = User("Bob", OwlContactSystem("4 Privet Drive"))

    print(f"Utilisateur 1: {alice.get_name()}")
    print(f"Utilisateur 2: {bob.get_name()}")


# Exécuter le programme
if __name__ == "__main__":
    main()
