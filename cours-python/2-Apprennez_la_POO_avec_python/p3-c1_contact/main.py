"""Point d'entrée"""

from contact.user import User

def main():
    """Main function."""
    alice = User("Alice")
    bob = User("Bob")
    # alice = User("Alice",TextContactSystem("0102030405"))
    # bob = User("Bob", OwlContactSystem("4 Privet Drive"))

    print(f"Utilisateur 1: {alice.get_name()}")


# Exécuter le programme
if __name__ == "__main__":
    main()
